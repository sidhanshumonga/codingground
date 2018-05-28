var getWeeks = function (sd, ed) {
                var arrayw = [];
                var i = 1;
                while (ed > sd) {
                    var wsd = new Date(sd);
                    var wed = new Date(sd);
                    var wed = wed.setDate(wed.getDate() + 6);
                    if (i < 10) { j = "0" + i; }
                    else { j = i; }
                    arrayw.push(new Date(wsd).getFullYear() + "W" + j + " - " + getProperDate(wsd) + " - " + getProperDate(new Date(wed)));
                    i++;
                    sd = new Date(sd).setDate(new Date(sd).getDate() + 7);
                }
                return arrayw;
            };
			
var getProperDate = function (d) {
    var y = d.getFullYear();
    var m = (d.getMonth() + 1);
    var dd = d.getDate();
    if(parseInt(m) < 10){ m = '0' + m}
    if(parseInt(dd) < 10){dd = '0' + dd}
    return y + "/" + m + "/" + dd;
}