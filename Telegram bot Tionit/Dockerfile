FROM python:3.9-alpine

ENV PYTHONDONTWRITEBYTECODE=1
ENV PYTHONUNBUFFERED=1

RUN mkdir -p /codebase /storage
ADD . /codebase
WORKDIR /codebase


RUN pip install --upgrade pip
RUN pip install -r requirements.txt

#CMD ["python3", "./src/telegram_bot.py"]
CMD python3 /codebase/src/telegram_bot.py;