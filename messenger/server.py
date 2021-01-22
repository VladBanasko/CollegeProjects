import flask
import time
from datetime import datetime

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
        'time1': time.time(),
        'time2':time.asctime(),
        'time3':datetime.now()
    }

app.run()