using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SourceControlWithDatabase {
    class StudentDB {
        public static void deleteStudent(int id) {
            SqlConnection connection = new SqlConnection("ConnectionStringGoesHere");

            SqlCommand deleteCommand = new SqlCommand();

            deleteCommand.Connection = connection;
            deleteCommand.CommandText = "DELETE QUERY";

            /* try {
                 connection.Open();

                 int rows = deleteCommand.ExecuteNonQuery(); // returns number of rows affected
             }
             //catch {
                 // An empty good catch is not usually a good idea
                 // We should catch specific exceptions
             //}
             finally {
                 connection.Dispose(); // This calls close() internally
             }*/

            // Using statements generate a try/finally block
            // Inside the finally, the dispose would be called
            using (SqlConnection connection2 = new SqlConnection()) {
                connection2.Open();
                //followed by other db code here
            } // Dispose() is automatically called at the end on whatever object is used in the using statement
        }
    }
}
