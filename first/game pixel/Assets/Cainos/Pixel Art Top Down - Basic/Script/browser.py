import sys
from PyQt5.QtCore import *
from PyQt5.QtWidgets import *
from PyQt5.QtWebEngineWidgets import *

class MainWindow(QMainWindow):
    def __init__(self):
        super(MainWindow. self).__init__()
        self.browser = QWebEngineView()
        self.browser.setUrl(QUrl('http://google.com'))
        self.setCentralWidget(self.browser)
        self.showMaximized()
        
    navbar = QToolbar()
    self.addToolBar(navbar)

    back_btn = QAction('Back', self)
    bact_btn.triggered.connect(self.browser.forward)
    navbar.addAction(forward_btn)
    