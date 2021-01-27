from datetime import datetime

from PyQt6 import QtWidgets, QtCore
import clientui
import requests


class Messenger(QtWidgets.QMainWindow, clientui.Ui_MainWindow):
    def __init__(self):
        super().__init__()
        self.setupUi(self)

        # to run on button on click
        self.pushButton.pressed.connect(self.send_message)

        self.after = 0
        # to run by timer:
        self.timer = QtCore.QTimer()
        self.timer.timeout.connect(self.get_messages())
        self.timer.start(1000)

    def get_messages(self):
        response = requests.get('http://127.0.0.1:5000/messages',
                                params={'after': self.after})
        messages = response.json()['messages']

        for message in messages:
            self.print_message(message)
            self.after = message['time']

    def print_message(self, message):
        message_time = datetime.fromtimestamp(message['time'])
        message_time = message_time.strftime('%Y/%m/%d %H:%M:%S')
        self.textBrowser.append(message_time + ' ' + message['name'])
        self.textBrowser.append(message['time'])
        self.textBrowser.append(' ')

        # print(message_time, message['name'])
        # print(message['text'])
        # print()

    def send_message(self):
        name = self.lineEdit.text()
        text = self.textEdit.toPlainText()
        requests.post('http://127.0.0.1:5000/send',
                      json={'name': name, 'text': text})

        self.textEdit.setText('')


app = QtWidgets.QApplication([])
window = Messenger()
window.show()
app.exec()
