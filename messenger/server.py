import flask
import time
from datetime import datetime

from flask import Flask, request, abort

app = Flask(__name__)

db = [
    {
        'text': 'Hi',
        'time': time.time(),
        'name': 'Nick'
    },
    {
        'text': 'Hi, Nick',
        'time': time.time(),
        'name': 'Jane'
    }
]


@app.route("/")
def hello():
    return "Hello, World!"


@app.route("/status")
def status():
    return {
        'status': True,
        'name': 'Python messenger',
        'time1': time.time(),
        'time2': time.asctime(),
        'time3': datetime.now(),

    }


@app.route("/send")
def send():
    # TODO
    return {'ok': True}


@app.route("/messages")
def get_messages():
    try:
        after = float(request.args['after'])
    except:
        return abort(400)

    messages = []
    for message in db:
        if message['time'] > after:
            messages.append(message)

    return {'messages': messages[:100]}


app.run()
