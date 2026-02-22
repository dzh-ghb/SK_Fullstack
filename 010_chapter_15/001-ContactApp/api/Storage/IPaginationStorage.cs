public interface IPaginationStorage : IStorage
{
    Contact GetContactById(int id);

    // метода пагинации (порционное возвращение данных)
    (List<Contact>, int totalCount) GetContactsPart(int pageNumber, int pageSize);
}