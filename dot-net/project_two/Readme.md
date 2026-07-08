Project “E-shop”
 • An online store that contains products and comments.
 
1- Defining the Model: We have two tables with a one-to-many relationship.
 • Products: id, name, description, price
 • Comments: id, title, content

 
2- Built the interface and repository, then linked them in Program.cs.
Interface: A list of rules to be implemented through the repository.


3- Setting up DbContext: The model folder is referenced to connect the model to the database. 
Then, the DbContext is registered in Program.cs.



4- Creating the Controller:
 • It receives requests and then executes them through the repository.
 • Route is used as the address through which the data is accessed.
 • HttpGet: Retrieves data.
 • HttpPost: Adds data.
 • HttpDelete: Deletes data.
 
 • In CommentController, productId is received to determine which product the comment belongs to.
Methods Used:
 • Constructor: Receives the repository and stores it.
 • GetAll: Retrieves all data.
 • GetById(id): Retrieves a specific product.
 • Create: Adds a new product.

 
DTOs: Data Transfer Objects A simplified version of the model without sensitive data to send to the user, to maintain security and prevent data interference.
 • The system was tested using Postman.
