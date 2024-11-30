const compose = (...funcs) => {
    const handlers = [];
    const composed = (x) => {
      if (funcs.length === 0) return x;
  
      const last = funcs.length - 1;
      let res = x;
      try {
        for (let i = last; i >= 0; i--) {
          res = funcs[i](res);
        }
        return res;
      } catch (error) {
        for (const handler of handlers) {
          handler(error);
        }
        return null;
      }
    };
    composed.on = (name, handler) => {
      if (name === "error") handlers.push(handler);
    };
    return composed;
  };

const inc = (x) => ++x;
const twice = (x) => x * 2;
const cube = (x) => x ** 3;

const f = compose(inc, twice, cube);
console.log(f(5));

const f2 = compose(inc, inc);
console.log(f2(7));

const f3 = compose(inc, 7, cube);
console.log(f3(4));