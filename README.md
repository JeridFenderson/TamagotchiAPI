# TamagotchiAPI

## Problem
Create a new sdg-api that has the following features
Create a database with a table named Pets

The API will have the following endpoints:
- POST /pets should create a new pet. The controller should ensure the following: Birthday defaults to the current DateTime, HungerLevel defaults to 0 and HappinessLevel defaults to 0
- GET /pets should return all pets in your database
- GET /pets/{id} should return the pet with the corresponding id
- DELETE /pets/{id}, should delete a pet from the database by Id
- POST /pets/{id}/playtimes should find the pet by id and add five to its happiness level and add three to its hunger level. It should also create a new Playtime for this pet and the current time
- POST /pets/{id}/feedings should find the pet by id and subtract five from its hungry level and add three to its happiness level. It should also create a new Feeding for this pet and the current time
- POST /pets/{id}/scoldings should find the pet by id and subtract five from its happiness level. It should also create a new Scolding for this pet and the current time

Demonstrate the API works, using Insomnia, screen capturing the API request and the response:
- create three Pets
- create a playtime for one of your pets
- create a feeding for one of your pets
- create a scolding for one of your pets
- show the details of all the pets

### Adventure Mode
Add columns LastInteractedWithDate (DateTime). When a pet is updated, set the LastInteractedWithDate to the current time. 

Add a property named IsDead to your Pet. The logic of this method will return true if LastInteractedWithDate is over three days old; otherwise, it will return false`.

Add a query parameter to GET /pets that only returns Pets that are alive.

### Epic Mode
Create a console app that interacts with the API that:
- allows the user to see all pets
- selects a pet to take care of and then play with, scold, or feed the selected pet
- creates a new pet
- deletes a pet

## Examples

Yes.

## Data

Pet Table/Class
- Id (int - automatic primary key)
- Name (string)
- Birthday (DateTime)
- HungerLevel (int)
- HappinessLevel (int)

Playtimes Table/Class
- Id (int - automatic primary key)
- When (DateTime)
- PetId (int - foreign key to Pet)

Feedings Table/Class
- Id (int - automatic primary key)
- When (DateTime)
- PetId (int - foreign key to Pet)

Scoldings Table/Class
- Id (int - automatic primary key)
- When (DateTime)
- PetId (int - foreign key to Pet)

## Algorithm

Create classes for all of the necessary data in a way that utilizes ef migrations and use migrations to build my database. 

Create a PetsController that does all the stuff from the problem.