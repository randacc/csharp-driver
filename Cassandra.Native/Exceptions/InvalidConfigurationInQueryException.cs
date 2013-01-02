using System;
using System.Collections.Generic;
using System.Text;

namespace Cassandra
{
    /**
     * A specific invalid query exception that indicates that the query is invalid
     * because of some configuration problem.
     * <p>
     * This is generally throw by query that manipulate the schema (CREATE and
     * ALTER) when the required configuration options are invalid.
     */
    public class CassandraClusterConfigErrorException : InvalidQueryException
    {
        public CassandraClusterConfigErrorException(string Message) : base(Message) { }
        public override RetryDecision GetRetryDecition(RetryPolicy policy, int queryRetries)
        {
            return RetryDecision.rethrow();
        }
    }
}