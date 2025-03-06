public class Person
{
    private Job job;

    Person()
    {
        this.job = new Job();
        System.out.println(job.salary);
    }
}
