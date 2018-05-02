<!-- Problem statement :  return the first repeating element in the given array-->

        var submit = function () {
            var array = ['hey', 'how', 'do', 'you', 'doing', 'hey', 'you', 'yes'];
            var hashmap = [];

            for (var i = 0; i < array.length; i++) {
                hashmap[array[i]] = true;
                if (hashmap[array[i + 1]] == true) {
                    console.log(array[i + 1]);
                    break;
                }
            }
        };

        var submit2 = function () {
            var array = ['hey', 'how', 'do', 'you', 'doing', 'hey', 'you', 'yes'];

            const count = array =>
                array.reduce((a, b) =>
                    Object.assign(a, { [b]: (a[b] || 0) + 1 }), {})

            const duplicates = dict =>
                Object.keys(dict).filter((a) => dict[a] > 1)

            console.log(count(array)) 
            console.log(duplicates(count(array)))
        };
  