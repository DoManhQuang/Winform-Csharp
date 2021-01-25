using System;
using System.Collections.Generic;
using System.Text;
using MongoDB.Bson;
using MongoDB.Driver;


namespace WindowsFormsApp1
{
    class BLLayer
    {
        DALayer GetDA = new DALayer();

        public List<BsonDocument> GET_LIST_FULL_DATA_TABLE_QnA()
        {
            String tableQA = "question_and_answer";
            List<BsonDocument> lstData = GetDA.Query_SELECT_O_FROM_TABLE(tableQA);
            return lstData;
        }
    }
}
