import javax.persistence.EntityManager;
import javax.persistence.EntityManagerFactory;
import javax.persistence.Persistence;
import javax.persistence.Query;

import com.bra3v3ku.autoskola.dao.Automobil;



public class Main {
	private static final String PERSISTENCE_UNIT_NAME = "eAutoskola";
	private static EntityManagerFactory factory;

	public static void main(String[] args) {
		factory = Persistence.createEntityManagerFactory(PERSISTENCE_UNIT_NAME);
		EntityManager em = factory.createEntityManager();
		// Read the existing entries and write to console
		Query q = em.createQuery("select t from Automobil t");
		java.util.List<Automobil> auta = q.getResultList();
		for (Automobil auto : auta) {
			System.out.println( auto.getZnacka() + " " + auto.getModel());
		}
		System.out.println("Size: " + auta.size());

		// Create new todo
		em.getTransaction().begin();
		Automobil todo = new Automobil();
		todo.setModel( "Octavia" );
		todo.setZnacka( "Skoda" );
		em.persist(todo);
		em.getTransaction().commit();

		em.close();
	}
	/* (non-Java-doc)
	 * @see java.lang.Object#Object()
	 */
	public Main() {
		super();
	}

}