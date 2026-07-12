# Task Management System

## Project Idea

The Task Management System is a simple Web API that allows users to create tasks, store them in a database, and retrieve them with support for filtering, sorting, and pagination.

The project was developed to practice the following concepts:

* Data Validation
* Filtering
* Sorting
* Pagination

The project follows an organized architecture consisting of:

* Controller
* Repository
* DTO
* Model
* Data

## Project Features

### 1. Create a New Task

After receiving a POST request, the system performs the following steps:

* Receives the request data.
* Validates the input data.
* Converts the DTO into a Model.
* Stores the task in the database.

### 2. Retrieve Tasks Using GET

**Filtering**

Users can retrieve tasks based on a specific priority level:

`Priority = High`

**Sorting**

Tasks can be sorted by due date in either ascending or descending order.

`SortBy = DueDate`

### 3. Pagination

When dealing with a large amount of data, returning all records at once is not recommended. Therefore, the project uses a page size of 10 records and combines the `Skip()` and `Take()` methods to retrieve only the required data, improving application performance.

### 4. Using DTO to Protect Data and Reduce Data Transfer

Instead of sending the entire Model, which contains all task properties, the project uses a DTO that includes only the required data for the request.

### 5. Using FluentValidation

The project validates the input data before storing it in the database.

* **Title:** Must not be empty and must not exceed the maximum allowed number of characters.
* **Priority:** Accepts only three values: `High`, `Medium`, and `Low`.
* **DueDate:** Must be a valid future date and cannot be in the past.

### 6. Controllers

The Controller acts as the entry point for handling HTTP requests and currently supports:

* GET
* POST
