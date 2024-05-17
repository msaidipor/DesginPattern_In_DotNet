using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
   
    /// <summary>
    /// Director
    /// </summary>
    public class QueryMaker
    {

    }

    /// <summary>
    /// abstract builder
    /// </summary>
    public  abstract class QueryBuilder
    {
       
        public Query query { get; private set; }

        protected QueryBuilder( )
        {
          
            this.Reset();
        }

        public abstract QueryBuilder Table(string table);
        public abstract QueryBuilder Where(string where);
        public abstract QueryBuilder Take(int count);   
        public abstract QueryBuilder Skip(int count);   
        public abstract QueryBuilder Select( string select);
        public abstract string GetQuery();

        private void Reset()
        {
            query = new Query();
        }

    }



    /// <summary>
    /// ConcreteBuilder
    /// </summary>
    public class SqlServerQuery : QueryBuilder
    {
       

        public override QueryBuilder Table(string table)
        {
            query.Table=table;
            return this;
        }

        public override QueryBuilder Where(string where)
        {
           query.Where=where;
            return this;
        }

        public override QueryBuilder Select(string select)
        {
            query.Select=select;
            return this;
        }

        public override QueryBuilder Skip(int count)
        {
            query.Skip=count;
            return this;
        }

      

        public override QueryBuilder Take(int count)
        {
            query.Take = count;
            return this;
        }

        public override string GetQuery()
        {
            return "sql server Query is: select " + query.Select+" from " + query.Table +" where " +query.Where + " take " + query.Take+ " skip "+query.Skip  ;
        }
    }

    public class MongoDbQuery : QueryBuilder
    {


        public override QueryBuilder Table(string table)
        {
            query.Table = table;
            return this;
        }

        public override QueryBuilder Where(string where)
        {
            query.Where = where;
            return this;
        }

        public override QueryBuilder Select(string select)
        {
            query.Select = select;
            return this;
        }

        public override QueryBuilder Skip(int count)
        {
            query.Skip = count;
            return this;
        }



        public override QueryBuilder Take(int count)
        {
            query.Take = count;
            return this;
        }

        public override string GetQuery()
        {
            return "MongoDB Query is: select " + query.Select + " from " + query.Table + " where " + query.Where + " take " + query.Take + " skip " + query.Skip;
        }
    }




    /// <summary>
    /// Product
    /// </summary>
    public class Query
    {

        public string Table { get; set; }
        public string Where { get; set; }
        public int Take { get; set; }
        public int Skip { get; set; }
        public string Select { get; set; }


       

    }


    #region Enum
    
    #endregion
}
