# LemonadeStand
Lemonade Stand Simulation Game

Austin - Open/Closed Principle - During the coding project when we were still in the planning phase. I thought that we could adhear to the Open/Closed principle by
making the list of weather into a parent "weather" class, and making the "weather conditions" into children classes. This gives the option to expand by easily adding
more children under the weather class, and into the randomizer to expand how dynamic the game is. It also means that the gameplay coding isnt changed when adding those
conditions.

Andrew - Open/Closed Principle and Liskov Substitution Principle in the Customer Class and its subsequent children classes
About halfway through planning and starting to code this project, we realized that it would be a good idea to make the 'Customer' class have inheritance to children classes.
These children classes would allow each customer to have varying ways that the recipe, price, and temperature affects their chance to buy a cup of lemonade.
Using the Open/Closed Principle in this case would let the list of customers generated for each day have the children hold the same base variables and just change the values 
of these variables based upon the child class called. This allows a programmer to add an additonal type of customer class without having to change the code. 
The way these are made are also using the Liskov Substituion Principle as any child of the Customer class does the same thing as the base Customer Class. The 'Man' class in this case
takes the original methods in the 'Customer' class and doesn't override them to make it the new default case. Creating these new classes let the code be open to extension and closed to modification.