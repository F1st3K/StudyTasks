.586
.model flat

public	_run

.data
prev	TBYTE 	180	
R1		TBYTE   0.25
R2		TBYTE   2
R3		TBYTE   4
A		TBYTE   26
B		TBYTE   30

.code
;3. z = 0.25*cos(B/pi)/(1+ctg(2A))+0.25*2tg(pi/4)
_run	proc
	
		 finit
		 fldpi
		 fld A

		 fmul prev
		 fdiv st, st(1)
		 




_run	endp
end

