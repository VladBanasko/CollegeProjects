import flask
import time

from flask import Flask

app = Flask(__name__)


@app.route("/")
def hello():
    return "Hello, World!"


@app.route("/status")
def status():
    return {
        'status': True,
        'name': 'Python messenger',
        'time': time.time(),
        'time':time.asctime(),
    }

app.run()