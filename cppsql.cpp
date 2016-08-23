//
#include <iostream>
#include <sstream>
#include <memory>
#include <string>
#include <stdexcept>

/* MySQL Connector/C++ specific headers */

#include <cppconn/driver.h>
#include <cppconn/exception.h>
#include <cppconn/resultset.h>
#include <cppconn/statement.h>

int main(void){
    try{
  sql::Driver *driver;
  sql::Connection *con;
  sql::Statement *stmt;
  //sql::ResultSet *res;

    driver = get_driver_instance();
    con = driver->connect("localhost","shane","Gaming12");

    con->setSchema("fair");

    stmt = con->createStatement();

    stmt->execute("INSERT INTO companies VALUES ('IOWA STATE FAIR',0,'quartz')");

    //delete res;
    delete stmt;
    delete con;

    }catch(sql::SQLException &e){

    }

    return 0;
}
