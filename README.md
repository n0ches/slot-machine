Assume that there is a slot machine which has three wheels that spin independently. Each wheel has 7 symbols: X, Y, Z, x, y, z and J (Joker).

The program must take three letters from the user as the characters on these wheels and print the coins he will get:

    - In the case of the same capital (upper-case) letters, he wins $30 
          i.e. (X X X) or (Y Y Y) or (Z Z Z)
         
    - In the case of the same lower-case letters, he wins $28 
          i.e. (x x x) or (y y y) or (z z z)

    - In the case of the same letters (both lower and upper), he wins $26 
          i.e. (X x x) or (y Y y) or (Z z Z) or …
          
    - In the case of consecutive capital letters, he wins $24 
          i.e. (X Y Z) or (Y Z X) or (Z X Y) or …
          
    - In the case of consecutive lower-case letters, he wins $22
         i.e. (x y z) or (y z x) or (z x y) or …
         
    - In the case of consecutive letters (both lower and upper), he wins $20 
         i.e. (x Y z) or (y Z X) or (Z x y) or …
         
    - In the case of capital letters, but not all the same letter and not consecutive, he wins $18 
         i.e. (X Y X) or (Z Z X) or …
         
    - In the case of lower-case letters, but not all the same letter and not consecutive, he wins $16 
         i.e. (x y x) or (z z x) or …
         
    - otherwise he gets $0

Joker (J) refers to any letter that allows us to earn the most money.

For example:

    J X X he wins $30
    J X J he wins $30
    J J J he wins $30
    X x J he wins $26
