# portuguese-grade-classification

## Creators

[Marco Vasquez](https://github.com/MarcoFidelVasquezRivera) - [Aleajandro Fonseca](https://github.com/AlejandroFonseca25) - [David Montoya](https://github.com/DSMontoyaP) - [Diego Garcia](https://github.com/Diego-ds)

## Program explanation:

The objective of this program is to use machine learning to predict the final grade of the portuguese course of some students from Lisboa.

This is the first release of the program in which you can load the students data from a .csv file, with the loaded data you can filter the table in any field and display charts based on the loaded data.

Programming language used: C#.

For more information about the program, visit the links below.

[Engineering method](https://github.com/MarcoFidelVasquezRivera/portuguese-grade-classification/blob/develop/docs/Método%20de%20Ingeniería%20-%20portuguese%20grade%20classification.pdf)

[Model package class diagram](https://github.com/MarcoFidelVasquezRivera/portuguese-grade-classification/blob/develop/docs/LoadData%20Branch%20ClassDiagram.pdf)

[GUI package class diagram](https://github.com/MarcoFidelVasquezRivera/portuguese-grade-classification/blob/develop/docs/GUI%20class%20diagram.pdf)

[Model package object diagram](https://github.com/MarcoFidelVasquezRivera/portuguese-grade-classification/blob/develop/docs/LoadData%20Branch%20ObjectDiagram.pdf)

[GUI package object diagram](https://github.com/MarcoFidelVasquezRivera/portuguese-grade-classification/blob/develop/docs/GUI%20Diagram%20Object.pdf)

[Explanation video](https://youtu.be/tOl-RGc9yCI)

## How the program works:

This is the first window you see when the program is executed, you can open a file dialog by clicking the button:

![image](https://user-images.githubusercontent.com/54712482/115126396-52ea6000-9f94-11eb-9cd0-295f1e5da682.png)

In this file manager you can select the .csv file and load the students data:

![image](https://user-images.githubusercontent.com/54712482/115126425-84632b80-9f94-11eb-9fea-a0fb5553dfac.png)

Once you have loaded the students data from the .csv file, a new window with three tabs is displayed, the Table tab allows you to see the table of students.

In the inferior left corner you have the filter, where you can choose any field and filter the table.

![image](https://user-images.githubusercontent.com/54712482/115126579-a6a97900-9f95-11eb-9161-f07bb97836a3.png)

The Charts tab allows you to see the information of some aspects of the student, when you first opent this tab it will look like this.

![image](https://user-images.githubusercontent.com/54719844/115127523-c2fce400-9f9c-11eb-83e3-7d888e8c1aa6.png)

If you choose "School name" then you will see a pie chart like this.

![image](https://user-images.githubusercontent.com/54719844/115127543-ef186500-9f9c-11eb-90c0-d3df0011d95c.png)

If you choose "Free time" then you will see a column chart like this.

![image](https://user-images.githubusercontent.com/54719844/115127568-18d18c00-9f9d-11eb-8500-c93d1c86a2db.png)

If you choose "Study time" then you will see a column chart like this.

![image](https://user-images.githubusercontent.com/54719974/115131315-d15af800-9fbc-11eb-950c-3ceefedb4a22.png)

If you choose "Address" then you will see a pie chart like this.

![image](https://user-images.githubusercontent.com/54719974/115131327-e9cb1280-9fbc-11eb-9ebf-5b9dece5f404.png)

If you choose "Internet access" then you will see a pie chart like this.

![image](https://user-images.githubusercontent.com/54719974/115131333-f9e2f200-9fbc-11eb-9413-bc34717c9fd0.png)

The Decision Tree tab allows you to build a decision tree from the database seen in the Table tab, visualize its precision with use of a pie chart and classify a custom, user-inserted student. 

80% of the database is used for tree training, picking rows at random and 20% is then used to check its precision. The percentage of correct and incorrect guesses is shown in a pie chart.

For classification of an user-inserted student, the user will provide data for several fields corresponding to all variables found within a student. If the data is valid, the program will show the predicted grade for that student. 

The objective variable for classification is the 3rd grade of an student. It ranges between 0 and 20, and the prediction done by the decision tree represents an interval that ranges from 0 to 10, with the following values from the 3rd grade:

Interval  |  Grade
1         |   0-1
2         |   2-3
3         |   4-5
4         |   6-7
5         |   8-9
6         |   10-11
7         |   12-13
8         |   14-15
9         |   16-17
10        |   18-19
11        |   20

![image](https://user-images.githubusercontent.com/54719974/118566880-52cbb480-b73a-11eb-9208-57856405fa16.png)

The Tree Graph tab allows graphic visualization of the decision tree built in the Decision Tree tab. The numbers found on the leaf nodes corresponds to the grade predicted by that leaf.

![image](https://user-images.githubusercontent.com/54719974/118567440-6af00380-b73b-11eb-93ab-6fd2c9d7dfb8.png)



