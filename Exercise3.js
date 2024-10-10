const objects = [ false, 23, 'Yes', 3, 4, false, 'Student', 'No', true, 0, true, 'Hi', 5, 5, false]
const counter = { 
    number: 0, 
    boolean: 0, 
    string: 0
}

objects.forEach((a) => {
    const type = typeof a;
    ++counter[type];
});
console.dir({ counter });