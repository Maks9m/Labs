const array = () => {
    const arr = [];
    const info = (i) => arr[i];
    info.push = (x) => arr.push(x);
    info.pop = () => arr.pop();
    return info;
  };

const arr = array();

arr.push('first');
arr.push('second');
arr.push('third');

console.log(arr(0));
console.log(arr(1));
console.log(arr(2));

console.log(arr.pop());
console.log(arr.pop());
console.log(arr.pop());

console.log(arr.pop());

