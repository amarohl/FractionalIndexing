# Fractional Indexing
A challenge to implement the body of a function that generates default fractional indices to a given length.

## Challenge Description
`GenerateDefaultFractionalIndices` returns an ordered list of `length` fractional index strings, throwing `ArgumentOutOfRangeException` for negative input. Each string is exactly 8 characters: a letter prefix, a base-62 number, `'f'` padding, and a final `'V'`. The prefix letter, starting at `'a'`, determines how many base-62 digits follow — one digit for `'a'`, two for `'b'`, three for `'c'`, and so on — with `'f'` characters filling the remainder to keep the total length fixed. Items fill each prefix group exhaustively before advancing to the next.

### Function output examples:
```
(0) → []
(2) → ["a0fffffV", "a1fffffV"]
(3) → ["a0fffffV", "a1fffffV", "a2fffffV"]
```

### String structure:
String     | Prefix   | Base-62 offset                      | Padding   | Terminator
---------- | -------- | ----------------------------------- | --------- | ----------
`a0fffffV` | `a`      | `0` (1 digit)                       | `fffff`   | `V`
`azfffffV` | `a`      | `61` (1 digit, last in group)       | `fffff`   | `V`
`b00ffffV` | `b`      | `0` (2 digits, first in next group) | `ffff`    | `V`