from aiogram.utils import executor
from create_bot import dp
from handlers import other, main_commands


async def on_startup(_):
    print('Бот вышел в онлайн')


main_commands.register_handlers_main_commands(dp)
other.register_handlers_other(dp)

executor.start_polling(dp, skip_updates=True, on_startup=on_startup)
