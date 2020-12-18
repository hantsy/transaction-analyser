# transaction-analyser

A Simple Transaction Analyzer to load and parse transaction records from CSV files.



## Prerequisite 

* Java 11 or Java 15(OpenJDK or AdoptOpenJDK)
* Apache Maven 3.6.3
* Git

## Build

 Clone the project source codes. 

```bash
git clone https://github.com/hantsy/transaction-analyser
```

Open your terminal, switch to the project root folder.

Execute the following command to compile the project. 

```bash
mvn clean compile
```

Build and run  the application in a single command.

```bash
mvn clean package exec:java

[INFO] --- exec-maven-plugin:1.6.0:java (default-cli) @ demo ---
fromDate (dd/MM/yyyy HH:mm:ss)
20/08/2020 12:00:00
toDate (dd/MM/yyyy HH:mm:ss):
20/08/2020 13:00:00
merchant:
Kwik-E-Mart
build transaction from line: WLMFRDGD, 20/08/2020 12:45:33, 59.99, Kwik-E-Mart, PAYMENT,
build transaction from line: YGXKOEIA, 20/08/2020 12:46:17, 10.95, Kwik-E-Mart, PAYMENT,
build transaction from line: LFVCTEYM, 20/08/2020 12:50:02, 5.00, MacLaren, PAYMENT,
build transaction from line: SUOVOISP, 20/08/2020 13:12:22, 5.00, Kwik-E-Mart, PAYMENT,
build transaction from line: AKNBVHMN, 20/08/2020 13:14:11, 10.95, Kwik-E-Mart, REVERSAL, YGXKOEIA
build transaction from line: JYAPKZFZ, 20/08/2020 14:07:10, 99.50, MacLaren, PAYMENT,
Number of transactions = 1
Average Transaction Value = 59.99
[INFO] ------------------------------------------------------------------------
[INFO] BUILD SUCCESS
[INFO] ------------------------------------------------------------------------
[INFO] Total time:  52.909 s
[INFO] Finished at: 2020-12-18T15:25:48+08:00
[INFO] ------------------------------------------------------------------------

```

## More ...

More Kotlin sample projects based on Spring stack.

* https://github.com/hantsy/spring-kotlin-coroutines-sample
* https://github.com/hantsy/spring-kotlin-dsl-sample 

Want to explore full Spring testing codes with several CI/CD integration configuration(Github Actions, Travis, Circle, Codefresh, Drone, SemaphoreCI, Appveyor, Shippable, etc.), check this sample project.

* https://github.com/hantsy/spring-reactive-jwt-sample

Like Java EE/Jakarta EE samples with Testing ready codes and CI/CD configuration(Github actions with different application servers, WildFly, Payara/Glassfish, Open Liberty, Apache TomEE, etc), check these samples.

* https://github.com/hantsy/jakartaee8-starter
* https://github.com/hantsy/jakartaee9-starter-boilerplate

