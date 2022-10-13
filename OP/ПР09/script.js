function div_str()
{
    let mainStr = frst.st.value;
    let str1 = "";
    let str2 = "";
    let str3 = "";
    let str4 = "";
    let lenghMain = mainStr.length;
    let numer = 1;
    let Sym = "";
    
    for (i=0; i<lenghMain; i++)
    {
        Sym = mainStr.substr(i,1)
        switch (numer)
        { 
            case 1 : { str1 += Sym; break;}         
            case 2 : { str2 += Sym; break;}
            case 3 : { str3 += Sym; break;}
            case 4 : { str4 += Sym; break;}
        }

        if (Sym == "." || Sym== "!" || Sym=="?")
        {
            numer++
            G1.innerText = "1. "+str1;
            G2.innerText = "2. "+str2;
            G3.innerText = "3. "+str3;
            G4.innerText = "4. "+str4;
       
        }
        
    }
    lenghMain = str2.length;
    let nstr = "";
    for (i=0; i<lenghMain; i++)
    {
        Sym = str2.substr(i,1);
        switch (Sym)
        { 
            case "1" : { nstr += "="+Sym; break;}         
            case "2" : { nstr += "="+Sym; break;}
            case "3" : { nstr += "="+Sym; break;}
            case "4" : { nstr += "="+Sym; break;}
            case "5" : { nstr += "="+Sym; break;}
            case "6" : { nstr += "="+Sym; break;}
            case "7" : { nstr += "="+Sym; break;}
            case "8" : { nstr += "="+Sym; break;}
            case "9" : { nstr += "="+Sym; break;}
            case "0" : { nstr += "="+Sym; break;}
        }
    }
    G5.innerText ="Числа из второй строки: "+nstr;
}   

