const objects = [ false, 23, 'Yes', 3, 4, false, 'Student', 'No', true, 0, true, 'Hi', 5, 5, false]
const counter = {}

objects.forEach((a) => {
    const type = typeof a;
if(!(type in counter))
    {
        counter[type] = 0;
    }
    ++counter[type];
});
console.dir({ counter });