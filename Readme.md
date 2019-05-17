# _Hair Salon_

#### _Allows a hair salon to create a list of employees and attach clients to one employee in the list_

#### By _**Jared Farkas**_

## Description

_Assigns clients to an employee within the list of employees. Should a client have too much hair cut, they will be killed and that employee may find scissors with which to more efficiently kill future clients. After each hair cut employees will also pocket any hair they cut, which can be utilized by them to increase their hair cutting efficiency, specialties for stylists can also be created and assigned to stylists._

## Setup/Installation Requirements

* _Clone from https://github.com/j-farkas/hair-salon.git_

*_To create the database:_*
>CREATE DATABASE jared_farkas;
> USE jared_farkas;
> CREATE TABLE `client` (
  `id` int(11) NOT NULL,
  `name` text,
  `stylist` int(11) NOT NULL,
  `hair` int(11) NOT NULL,
  `haircut` text
);

  > CREATE TABLE `join` (
    `id` int(11) NOT NULL,
    `scissors_id` int(11) NOT NULL,
    `client_id` int(11) NOT NULL,
    `stylist_id` int(11) NOT NULL,
    `prefix_id` int(11) NOT NULL,
    `suffix_id` int(11) NOT NULL,
    `specialty_id` int(11) NOT NULL
  );

  >CREATE TABLE `prefix` (
    `id` int(11) NOT NULL,
    `name` text,
    `max_value` int(11) NOT NULL,
    `min_value` int(11) NOT NULL
  );

  >INSERT INTO `prefix` (`id`, `name`, `max_value`, `min_value`) VALUES
  (1, 'Sturdy', 3, 2),
  (2, 'Strong', 5, 3),
  (3, 'Sharp', 10, 5),
  (4, 'Steel', 15, 8),
  (5, 'Silver', 20, 10),
  (6, 'Gold', 25, 13),
  (7, 'Diamond', 35, 18),
  (8, 'Magic', 50, 25);

  >CREATE TABLE `scissors` (
    `id` int(11) NOT NULL,
    `name` text,
    `prefix_1` int(11) NOT NULL,
    `prefix_1_value` int(11) NOT NULL,
    `prefix_2` int(11) NOT NULL,
    `prefix_2_value` int(11) NOT NULL,
    `suffix_1` int(11) NOT NULL,
    `suffix_1_value` int(11) NOT NULL,
    `suffix_2` int(11) NOT NULL,
    `suffix_2_value` int(11) NOT NULL,
    `quality` int(11) NOT NULL
  );
>INSERT INTO `scissors` (`id`, `name`, `prefix_1`, `prefix_1_value`, `prefix_2`, `prefix_2_value`, `suffix_1`, `suffix_1_value`, `suffix_2`, `suffix_2_value`, `quality`) VALUES
(0, 'Scissors', 0, 0, 0, 0, 0, 0, 0, 0, 0));

>CREATE TABLE `specialty` (
  `id` int(11) NOT NULL,
  `name` text
);

>CREATE TABLE `stylist` (
  `id` int(11) NOT NULL,
  `name` text,
  `description` text,
  `level` int(11) NOT NULL,
  `hair` int(11) NOT NULL,
  `scissors` int(11) NOT NULL,
  `drop` int(11) NOT NULL
);

>CREATE TABLE `suffix` (
  `id` int(11) NOT NULL,
  `name` text,
  `max_value` int(11) NOT NULL,
  `min_value` int(11) NOT NULL
);
>INSERT INTO `suffix` (`id`, `name`, `max_value`, `min_value`) VALUES
(1, 'Weakness', 5, 1),
(2, 'Strength', 5, 1),
(3, 'Fragility', 10, 6),
(4, 'Cutting', 10, 6),
(5, 'Safety', 20, 11),
(6, 'Shaving', 20, 11),
(7, 'Chance', 2, 1),
(8, 'Luck', 4, 3),
(9, 'Fortune', 6, 5),
(10, 'Riches', 10, 10);

* _Use dotnet run and load it from localhost_

## Specs

| Behavior | Input | Output |
| ------------- |:-------------:| -----:|
| A stylist is added to the form | "Namey"  | A stylist is added to the database |
| A client is added to the form using a dropdown to select their stylist | "Clienty" | A client is added to the database with a foreign key to reference their stylist |
| In the client show screen, a new stylist is selected | n/a | the foreign key for the selected client is changed in the database to reflect their new stylist |
| In the client show screen, a haircut is selected and the client has hair remaining | n/a | The stylist keeps the hair and progresses towards the next level|
| In the client show screen, a haircut is selected and the client has negative hair remaining | n/a | The client is killed, a random pair of scissors is generated for the stylist, and hair is taken to progress the stylist to the next level|

## Known Bugs

_None currently known_

## Support and contact details

_Contact jaredmfarkas@gmail.com for support._

## Technologies Used

_C#, .Net, Razor asp.net, MySql, Entity Framework_

### License

*This software is licensed under the MIT license.*

Copyright (c) 2019 **_Jared Farkas_**
