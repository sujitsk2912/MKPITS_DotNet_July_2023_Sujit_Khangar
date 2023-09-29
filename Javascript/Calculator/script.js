 var pnum=0;
 var cnum=0;
 var result=0;
 var op;

 function one()
 {
    op=document.form.display.value;
    document.form.display.value="1";
 }

 function two()
 {
    op=document.form.display.value;
    document.form.display.value="2";
 }

 function three()
 {
    op=document.form.display.value;
    document.form.display.value="3";
 }

 function four()
 {
    op=document.form.display.value;
    document.form.display.value="4";
 }

 function five()
 {
    op=document.form.display.value;
    document.form.display.value="5";
 }

 function six()
 {
    op=document.form.display.value;
    document.form.display.value="6";
 }

 function seven()
 {
    op=document.form.display.value;
    document.form.display.value="7";
 }

 function eight()
 {
    op=document.form.display.value;
    document.form.display.value="8";
 }

 function nine()
 {
    op=document.form.display.value;
    document.form.display.value="9";
 }

 function zero()
 {
    op=document.form.display.value;
    document.form.display.value="0";
 }

 function plus()
 {
    pnum=parseInt(document.form.display.value);
    document.form.display.value="+"
 }

 function minus()
 {
    pnum=parseInt(document.form.display.value);
    document.form.display.value="-"
 }

 function multiply()
 {
    pnum=parseInt(document.form.display.value);
    document.form.display.value="*"
 }

 function division()
 {
    pnum=parseInt(document.form.display.value);
    document.form.display.value="/"
 }

 function equals_to()
 {
    cnum=parseInt(document.form.display.value);

    if(op == "+")
    {
        document.getElementById("display").value=pnum+cnum;
    }

    else if(op == "-")
    {
        document.getElementById("display").value=pnum-cnum
    }

    else if(op== "*")
    {
        document.getElementById("display").value=pnum*cnum;
    }

    else if (op == "/")
    {
        document.getElementById("display").value=pnum/cnum;
    }
 }

 function Ac()
 {
    pnum=parseInt(document.form.display.value);
    document.form.display.value=""
 }


