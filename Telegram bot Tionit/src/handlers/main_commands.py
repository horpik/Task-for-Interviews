from aiogram import types, Dispatcher

from create_bot import bot


async def command_start(message: types.Message):
    await bot.send_message(message.from_user.id,
                           'Бот запущен\n')
    await message.delete()


def register_handlers_main_commands(dp: Dispatcher):
    dp.register_message_handler(command_start, commands=['start', 'help'])
