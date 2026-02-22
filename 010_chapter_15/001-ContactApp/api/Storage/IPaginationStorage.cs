public interface IPaginationStorage : IStorage
{
    Contact GetContactById(int id);

    // метод пагинации (порционное возвращение данных)
    (List<Contact>, int totalCount) GetContactsPart(int pageNumber, int pageSize);
}