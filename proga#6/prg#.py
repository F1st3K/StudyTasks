from PySide2 import QtCore, QtGui, QtWidgets
import sys
import random
from prg import Ui_Dialog

app = QtWidgets.QApplication(sys.argv)    
   
Dialog = QtWidgets.QDialog()
ui = Ui_Dialog()
ui.setupUi(Dialog)
Dialog.show()
# Логика приложения

def bp1_1():
	r = str(1)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 2))
	b = str(random.randint(1, 2))
	ui.lineEdit.setText(a)
	ui.lineEdit_2.setText(b)
	if a != r or b != r:
		s -= 250
		ui.label_12.setText("Вы проиграли -250$ (((")
	elif a == r and b == r:
		s += 750
		ui.label_12.setText("Вы выйграли +750$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton.clicked.connect(bp1_1)
def bp1_2():
	r = str(2)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 2))
	b = str(random.randint(1, 2))
	ui.lineEdit.setText(a)
	ui.lineEdit_2.setText(b)
	if a != r or b != r:
		s -= 250
		ui.label_12.setText("Вы проиграли -250$ (((")
	elif a == r and b == r:
		s += 750
		ui.label_12.setText("Вы выйграли +750$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_2.clicked.connect(bp1_2)
def bp2_1():
	r = str(1)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 2))
	b = str(random.randint(1, 2))
	c = str(random.randint(1, 2))
	ui.lineEdit_3.setText(a)
	ui.lineEdit_4.setText(b)
	ui.lineEdit_5.setText(c)
	if a != r or b != r or c != r:
		s -= 250
		ui.label_15.setText("Вы проиграли -250$ (((")
	elif a == r and b == r and c == r:
		s += 1000
		ui.label_15.setText("Вы выйграли +1000$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_3.clicked.connect(bp2_1)
def bp2_2():
	r = str(2)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 2))
	b = str(random.randint(1, 2))
	c = str(random.randint(1, 2))
	ui.lineEdit_3.setText(a)
	ui.lineEdit_4.setText(b)
	ui.lineEdit_5.setText(c)
	if a != r or b != r or c != r:
		s -= 250
		ui.label_15.setText("Вы проиграли -250$ (((")
	elif a == r and b == r and c == r:
		s += 1000
		ui.label_15.setText("Вы выйграли +1000$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_4.clicked.connect(bp2_2)
def bp3_1():
	r = str(1)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 3))
	b = str(random.randint(1, 3))
	c = str(random.randint(1, 3))
	ui.lineEdit_6.setText(a)
	ui.lineEdit_7.setText(b)
	ui.lineEdit_8.setText(c)
	if a != r or b != r or c != r:
		s -= 250
		ui.label_18.setText("Вы проиграли -250$ (((")
	elif a == r and b == r and c == r:
		s += 2500
		ui.label_18.setText("Вы выйграли +2500$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_5.clicked.connect(bp3_1)
def bp3_2():
	r = str(2)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 3))
	b = str(random.randint(1, 3))
	c = str(random.randint(1, 3))
	ui.lineEdit_6.setText(a)
	ui.lineEdit_7.setText(b)
	ui.lineEdit_8.setText(c)
	if a != r or b != r or c != r:
		s -= 250
		ui.label_18.setText("Вы проиграли -250$ (((")
	elif a == r and b == r and c == r:
		s += 2500
		ui.label_18.setText("Вы выйграли +2500$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_7.clicked.connect(bp3_2)
def bp3_3():
	r = str(3)
	f = open('s = .txt', 'r')
	s = int(f.read())
	f.close()
	a = str(random.randint(1, 3))
	b = str(random.randint(1, 3))
	c = str(random.randint(1, 3))
	ui.lineEdit_6.setText(a)
	ui.lineEdit_7.setText(b)
	ui.lineEdit_8.setText(c)
	if a != r or b != r or c != r:
		s -= 250
		ui.label_18.setText("Вы проиграли -250$ (((")
	elif a == r and b == r and c == r:
		s += 2500
		ui.label_18.setText("Вы выйграли +2500$ !!!")
	ui.label_8.setText(str(s))
	v = open('s = .txt', 'w')
	v.write(str(s))
	v.close()
ui.pushButton_6.clicked.connect(bp3_3)
def name():
	j = ui.lineEdit_9.text()
	o = open('name.txt', 'w')
	o.write(str(j))
	o.close()
	o = open('name.txt', 'r')
	y = str(o.read())
	o.close
	ui.label_9.setText(str(y))
	ui.label_13.setText(str(y))
	ui.label_16.setText(str(y))
ui.pushButton_9.clicked.connect(name)
def start():
	f = open('s = .txt', 'r')
	ui.label_8.setText(str(f.read()))
	f.close()
	o = open('name.txt', 'r')
	ui.lineEdit_9.setText(str(o.read()))
	o.close()
ui.pushButton_8.clicked.connect(start)
def cheat():
	g = ui.spinBox.cleanText()
	i = open('s = .txt', 'w')
	i.write(str(g))
	i.close()
	i = open('s = .txt', 'r')
	x = str(i.read())
	i.close
	ui.label_8.setText(str(x))
ui.pushButton_10.clicked.connect(cheat)


# Запуск основного цикла
sys.exit(app.exec_())

