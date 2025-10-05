## 2. Java (SQL Injection)

In a Java application using JDBC, creating a `Statement` and building the query with string concatenation instead of using a `PreparedStatement` will trigger the alert.

| **Vulnerable Code (BAD)** | **CodeQL Flag ID** |
| :--- | :--- |
| **`MyClass.java`** | `java/sql-injection` (Severity: High) |
| ```java
import java.sql.Connection;
import java.sql.Statement;

public void getUser(Connection connection, String userId) {
    // userId is assumed to be an unvalidated user-controlled source
    
    // BAD: Building a query string by concatenating user input
    String query = "SELECT * FROM users WHERE id = '" + userId + "'";
    
    try {
        Statement statement = connection.createStatement();
        statement.executeQuery(query); // This is the 'sink'
    } catch (Exception e) {
        // ...
    }
}
``` | |

**Why CodeQL flags it:** The unvalidated `userId` is concatenated directly into the `query` string, and this string is passed to `statement.executeQuery()`, which is a recognized **Sink** for SQL injection.
