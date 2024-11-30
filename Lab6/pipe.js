const pipe =
  (...funcs) =>
  (x) => {
    if (funcs.length === 0) throw new Error("No arguments were initialized");

    let res = x;
    for (let i = 0; i < funcs.length; i++) {
      if (typeof funcs[i] !== "function")
        throw new Error("Only functions can be added to pipe arguments");
      res = funcs[i](res);
    }
    return res;
  };

const inc = (x) => ++x;
const twice = (x) => x * 2;
const cube = (x) => x ** 3;

const f = pipe(inc, twice, cube);
console.log(f(5));

const f2 = pipe(inc, inc);
console.log(f2(7));

const f3 = pipe(inc, 7, cube);
console.log(f3(4));