# Innovation Day 06.12.2024 - dolt

Today we have a closer look into [dolt](https://github.com/dolthub/dolt) a SQL Server database combined with the functionalities of git. 

We are following the introduction section on the [DoltHub](https://docs.dolthub.com).

## Installation

We were using DevPod (base image ubuntu) on a MacBook (m1) and creating a workspace cloning an empty GitHub repository.

### Install dolt

To install dolt on Ubuntu you can use the following command
```bash
sudo bash -c 'curl -L https://github.com/dolthub/dolt/releases/latest/download/install.sh | sudo bash'
```

You can find other options to install it on Windows, Mac or using Docker [here](https://docs.dolthub.com/introduction/installation).

## Getting Started

Set the configuration data for dolt exactly you would do it for git
```bash
dolt config --global --add user.name "your name"
dolt config --global --add user.email "your email"
```

Create a data folder
```bash
mkdir data
cd data
```

Initialise a new dolt database in the current folder. The name of the database is the folder name.
```bash
dolt init
```

Check data repository log
```bash
dolt log --oneline
```

## Add data
We will use the employee.csv file in the root of the repository to add data to the database using the table import and the --create-table option which creates a new table "employee" with the primary key "id".
```bash
dolt table import --create-table --pk id employee ../employees.csv
```

Dolt works like git and has a staging area. You can see the status of the database using the status command.
```bash
dolt status
```

You can query the data using SQL
```bash
 dolt sql -q "select * from employee"
 ```
Add the changes to the staging area
```bash
dolt add .
```

Commit the changes to the database
```bash
dolt commit -m "feat: add employee table"
```

## Using branches
You can create a new branch using the branch command
```bash
dolt checkout -b feature/employee
```

You can add new data to the employee table
```bash
dolt sql -q "insert into employee values (21, 'Konrad','Zuse')
```

Add the changes & commit the changes
```bash
dolt add .
dolt commit -m "feat: add Konrad Zuse to employee table"
```

You can switch back to the main branch using the checkout command
```bash
dolt checkout main
```

You can merge the feature branch into the main branch
```bash
dolt merge feature/employee
```