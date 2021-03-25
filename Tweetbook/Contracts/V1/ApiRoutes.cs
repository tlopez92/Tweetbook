namespace Tweetbook.Contracts.V1
{
    public static class ApiRoutes
    {
        private const string Root = "api";
        private const string Version = "v1";
        private const string Base = Root + "/" + Version;
        public static class Posts
        {
            public const string GetAll = Base + "/post";
            public const string Update = Base + "/post/{postId}";
            public const string Delete = Base + "/post/{postId}";
            public const string Get = Base + "/post/{postId}";
            public const string Create = Base + "/post";
        }

        public static class Identity
        {
            public const string Login = Base + "/identity/login";
            public const string Register = Base + "/identity/register";
            public const string Refresh = Base + "/identity/refresh";
        }

        public static class Tags
        {
            public const string GetAll = Base + "/tags";
        }
    }
}