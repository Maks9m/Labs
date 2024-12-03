const seq = (f) => (g) => typeof g === "number" ? f(g) : seq(x => f(g(x)));

console.log(seq(x => x * 2)(x => x + 7)(5));
console.log(seq(x => x + 1)(x => x * 2)(x => x / 3)(x => x - 4)(7));
console.log(seq(x => x * 10)(x => x - 4)(5));//sdgfd