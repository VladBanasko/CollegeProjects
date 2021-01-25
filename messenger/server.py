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


@app.route("/send", methods=['POST'])
def send_message():

    if isinstance(request.json, dict):
        return abort(400)
    if 'name' not in request.json:
        return abort(400)
    if 'text' not in request.json:
        return abort(400)

    name = request.json['name']
    text = request.json['text']

    if not isinstance(name, str):
        return abort(400)
    if not isinstance(text, str):
        return abort(400)
    if 'name' == '' or 'text' == '':
        return abort(400)

    message = {
        'text': text,
        'time': time.time(),
        'name': name
    }
    db.append(message)
    return {'ok', True}


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
