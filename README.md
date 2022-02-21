# QuadraticEquationSolver
Консольний додаток для вирішення квадратних рівнянь.

**Додаток працює у двох режимах:**
- *Інтерактивний*
  
  Користувач вводить по черзі три коефіцієнта: a, b та c. 
  Програма складає на їх основі рівняння та вирішує його.
  Застосунок працює в такому режимі, якщо не було передано жодного аргументу.
  
- *Неінтерактивний (файловий)*
  
  Програма приймає один аргумент — шлях до файлу з коефіцієнтами рівняння.
  У файлі записано 3 числа: a b c розділених між собою одним пробілом. 
  У якості десяткового символу очікується крапка. 
  Після останнього коефіцієнту (с) — символ нового рядка (\n) і на цьому файл закінчується.
  На основі зчитаних із файлу коефіцієнтів програма складає та вирішує рівняння.
  
  # Встановлення .NET6.0
  
  Для запуску застосунку, потрібно встановити .NET 6.0
  
   **Windows**
   
   Завантажте за посиланням: https://dotnet.microsoft.com/en-us/download/dotnet
   
    **Linux**
    
  Додайте ключ підпису пакета Microsoft до списку перевірених ключів і додайте репозиторій:
  
  ```wget https://packages.microsoft.com/config/ubuntu/21.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb``` 
  
  ```sudo dpkg -i packages-microsoft-prod.deb```
  
  ```rm packages-microsoft-prod.deb```
  
  Встановіть пакет SDK для .NET:
  
  ```sudo apt-get update```
  
  ```sudo apt-get install -y apt-transport-https```
  
  ```sudo apt-get update```
  
  ```sudo apt-get install -y dotnet-sdk-6.0```
  
  Встановіть середовище виконання .NET:
  
  ```sudo apt-get install -y dotnet-runtime-6.0```
  
  # Запуск проєкту
  
  **Windows**
  
  *1 варіант (Visual Studio)*
  
  Встановіть та запустіть на своєму комп'ютері Visual Studio.
  У початковому вікні виберіть розділ "Клонувати репозиторій".
  Введіть або вкажіть розташування репозиторію, а потім натисніть кнопку Клонувати.
  Щоб передати аргументи командного рядка у Visual Studio потрібно:
  Вибрати у верхньому меню панель Project; У вкладці вибрати Properties;
  У вікні, що відкрилося, вибрати Debug;У правій частині задати аргументи у полі Command line arguments.
  
  *2 варіант (Командний рядок)*
  
  Сколонуйте репозиторій. Через командний рядок перейдіть у робочу директорію "QuadraticEquationSolver".
  Запустіть проєкт:
  
  ```dotnet run [arguments]```
  
  **Linux**
  
  Склонуйте репозиторій:
  
  ```git clone https://github.com/juliion/QuadraticEquationSolver.git```
  
  Перейдіть у робочу директорію сколонованого проєкту "QuadraticEquationSolver":
  
  ```cd QuadraticEquationSolver/QuadraticEquationSolver```
  
  Запустіть проєкт:
  
  ```dotnet run [arguments]```
 
 
 **revert-коміт**: https://github.com/juliion/QuadraticEquationSolver/commit/3b4e37ac52b2d513b647574fcd4b55d59d9d6381

 
 


 
 
