# Comp586
This is my Final Project for Comp586 
I built a website that shows the titles of movies and their directors with a C# ASP.NET backend and Angular frontend.  
The Site is viewable here https://webapplication420181211022930.azurewebsites.net/  
Below are the requirements for this project.  <br/>
*MVC*  
Models, Controllers in backend. Views in frontend with angular and all routing.  <br/>  
*ORM*  
Used Entity Framework with SQlite.  
I have a total of three tables: Movies (lists movies and directors), user(lists userid, password, and fKeyId), and MoviesList(User and movies)  
A single user can have a one to many relationship with the amount of movies they wish to have.  <br/>  
*SPA*  
Angular get methods implemented in Service.ts and called in movie-detail and browse components. 
Get methods display details of a movie based on title.
Post method written to add movies to a list, but its not implemented properly <br/>  
*Dependency Injection*  
DI in backend with injecting database context in the Movie controllers.
DI in frontend with services movieService.ts, authService.ts, httpClient<br/>  
*Auth*  
Using auth0 to login/signup. Can use below to test.
UserName: John@me.com 
Password: Password1
