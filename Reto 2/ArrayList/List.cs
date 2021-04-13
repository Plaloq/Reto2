namespace Reto_2
{
    public interface List<T>
    {

        void add(T data);

        int getSize();

        T get(int index);

        void delete(int index);

        Iterator<T> getIterator();

        Iterator<T> getReverseIterator();

    }
}