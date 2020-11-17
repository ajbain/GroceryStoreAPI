# GroceryStoreAPI Team Happy

## Introduction:
The aim of this project was implement AGILE methodology, as well as team Git practices into an API application. Our team chose a Grocery Store API, making classes for Ingredients, Recipes, and Transactions. 

This project implements CRUD into our database creation, as well as testing endpoints of our APIs using Postman. We created a google sheet that included tickets/ user stories to help us understand the AGILE methodology.Our Postman Port number was: 44326.

We then assigned points to these user stories to figure out the effort and time commitment these tickets would take. This was done in a shared GoogleDoc that you can see at this URL. https://docs.google.com/spreadsheets/d/1hq0anjxkZPiXSHoJskFoaV_RJcUS15_oT-f6nk0hH6M/edit#gid=0

## Technologies
Net Framework C#\
PostMan\
Trello\
GoogleDocs

## Launch
Visual Studio Community 2019 Version16.7.5\
Microsoft .Net Framework Version 4.8.04084

## Steps
We first Created a Trello board based off of an initial GoogleDoc plan that can be found at this URL: https://trello.com/b/TzIG1oni/grocery-list. You will need a trello account to view this board and may need access granted by our team. We are new to this and not entirely sure if those outside the team can view it. Please contact a member of the Happy team if you have access issues. \
After creating a Trello board to log ticket issues/items, we loaded in our User Stories. These User Stories helped in our AGILE planning-- since we were imagining a situation where a user might need something in particular. User Stories were created into Tickets for our team to work through. Teammates would pull a ticket from the queue on Trello, work on the assigned ticket, and then add those specifications to a specific branch on Github. These branches were then merged into the 'default' branch and re-pulled down from Github so we could work with the latest code. \
Once users pushed their code and it was merged, other users would be able to pull the code down from that particular branch and be able to help with testing the methods & endpoints on Postman. This was repeated over and over until we had either 1). Run out of tickets, or 2). Our project time was up. 

## Issues
We ran into issues in trying to tie the API to a console as both could not run within the same solution concurrently.
Our team also needed to create an intermediary/joiner class for the ingredients list used in the recipe class. This was needed to create a one to one relationship where the joiner table pulls in many items into a list but is a single item for the recipe class to reference.

We also ran into issues with our planned recipe class as we needed a joiner table with a one to many relationship that we could then tie to our recipe for a one to one relationship.

## Learning points
We have learned more about merging solutions in Github, AGILE planning, and have become more confident backend software developers during this project. We have also expounded our knowledge on creating CRUD methods and Foreign-Key relationships in .Net APIs. 

## Examples of Use
This project would likely be used as a shopping app. We had started this application with that intent--that we would be similar to a grocery app. We then added recipes to our application-- allowing users to peruse recipes. This might entice users to buy more groceries. Both the ingredients and the recipes would only contain items that would be located in our store. 

## Resources
Resources used during project where visual studios using C# in .NET framework version 4.8. This project is an API ASP.Net Web Application with individual user accounts.
We used Google Docs to arrange our thoughts in the planning phase: https://docs.google.com/spreadsheets/d/1hq0anjxkZPiXSHoJskFoaV_RJcUS15_oT-f6nk0hH6M/edit#gid=0
We used Trello to manage our work flow:  https://trello.com/b/TzIG1oni/grocery-list .
We used Zoom to communicate within the team and with our instructors when we required assistance.\
This project is part of our Blue badge work done for Eleven Fifty Academy we are in the SD 69 Blue 11-5-20 class for Eleven Fifty academy and we are Team Happy
We relied on assistance from our Teacher, Andrew, and Learning Assistant--Trevor.\






