        
        var pnum=0;
        var cnum=0;
        var result=0;
        var op;

        function one()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "1";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="1";
            }
        }

        function two()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "2";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="2";
            }
        }

        function three()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "3";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="3";
            }
        }

        function four()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "4";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="4";
            }
        }

        function five()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "5";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="5";
            }
        }

        function six()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "6";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="6";
            }
        }

        function seven()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "7";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="7";
            }
        }

        function eight()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "8";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="8";
            }
        }

        function nine()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "9";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="9";
            }
        }

        function zero()
        {
            if(document.form.display.value != "+" && document.form.display.value != "-" && document.form.display.value != "*" && document.form.display.value != "/"   )
            {
                document.form.display.value = document.form.display.value + "0";
            }

            else
            {
                op=document.form.display.value;
                document.form.display.value="0";
            }
        }

        function plus()
        {
            op="+"
            pnum=parseInt(document.form.display.value);
            document.form.display.value="+"
        }

        function minus()
        {
            op="-"
            pnum=parseInt(document.form.display.value);
            document.form.display.value="-"
        }

        function multiply()
        {
            op="*"
            pnum=parseInt(document.form.display.value);
            document.form.display.value="*"
        }

        function division()
        {
            op="/"
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
            op=document.form.display.value;
            document.form.display.value=""
        }
