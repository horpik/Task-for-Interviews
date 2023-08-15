import os

from aiogram import types, Dispatcher
from create_bot import bot

count_thread = 2

group_id = int(os.getenv('GROUP_ID'))

dict_user = {
    # 'user_id': ['first_name', 'thread_id'],
}
dict_thread = {
    # 'thread_id': 'user_id',
}

admins_list = os.getenv('ADMINS_ID').replace(' ', '').split(',')
for el in admins_list:
    el = int(el)


async def create_thread(channel_id, thread_title, user_id, message_id):
    new_topik = await bot.create_forum_topic(channel_id, thread_title)
    await bot.forward_message(chat_id=channel_id, from_chat_id=user_id,
                              message_thread_id=new_topik.message_thread_id, message_id=message_id)
    dict_user[user_id] = [thread_title, new_topik.message_thread_id]
    dict_thread[new_topik.message_thread_id] = user_id


async def echo_send(message: types.Message):
    if str(message.from_user.id) in admins_list:
        if str(message.chat.id) == str(group_id):
            if message.message_thread_id is not None:
                await bot.send_message(dict_thread[message.message_thread_id], message.text)
    if message.from_user.id in dict_user:
        if str(message.chat.id) != str(group_id):
            user_id = message.from_user.id
            if message.chat.id != group_id:
                await bot.forward_message(chat_id=group_id, from_chat_id=user_id,
                                          message_thread_id=dict_user[user_id][1], message_id=message.message_id)
    else:
        if str(message.chat.id) != str(group_id):
            await create_thread(group_id, message.from_user.first_name, message.from_user.id, message.message_id)


def register_handlers_other(dp: Dispatcher):
    dp.register_message_handler(echo_send)
