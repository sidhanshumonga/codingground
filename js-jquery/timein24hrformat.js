//Problem Statement : return time in 24 hour format according to given input


        var submit = function () {
            var input = '07:05:29AM'; // taking static input

            if (input.substring(8, 10) == "PM") {
                console.log((parseInt(input.substring(0,2))+12) + input.substring(2,8) );
            }
            else{
                console.log(input.substring(0,8));
            }
        };
