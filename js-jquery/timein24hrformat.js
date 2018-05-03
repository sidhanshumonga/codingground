// created by sidhanshu monga
// 02 may, 2018

//Problem Statement : return time in 24 hour format according to given input

    var input = '12:05:29PM'; // taking static input

            if (input.substring(8, 10) == "PM") {
                if(input.substring(0,2) == "12"){
                    console.log(input.substring(0,8));
                }
                else{
                    console.log((parseInt(input.substring(0,2))+12) + input.substring(2,8) );
                }
            }
            else{
                if(input.substring(0,2) == "12"){
                    console.log((parseInt(input.substring(0,2))-12) + "0" + input.substring(2,8) );
                }
                else{
                      console.log(input.substring(0,8)); 
                }
            }
