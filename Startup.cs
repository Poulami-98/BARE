public void ConfigureServices(IServiceCollection services)
{
    services.AddDbContext<DictionaryContext>(options =>
        options.UseSqlite("Data Source=dictionary.db"));
    services.AddControllers();
}
