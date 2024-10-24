"use strict";

// Implement function `range(start: number, end: number): array` returning
// array with all numbers from the range [15, 30] including endpoints

const range = (start, end) => {
  const length = end - start;
  const array = [];
  for (let i = 0; i <= length; i++) {
    array[i] = start + i;
  }
  return array;
};

module.exports = { range };
