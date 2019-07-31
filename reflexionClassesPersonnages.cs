class Personnages
{
	// Classe mère de tous les personnages et définitions principales
}

class PersonnagesStatiques : Personnages
{
	// Classe fille de "Personnages" et décrivant l'orientation des personnages ainsi que d'autres définitions principales
	// Surcharge des définitions de "Personnages" ?
}

class PersonnagesMobiles : Personnages
{
	// Classe fille de "Personnages" et décrivant les mouvements des personnages ainsi que d'autres définitions principales
	// Surcharge des définitions de "Personnages" ?
	
	// Définition des mouvements des personnages (ne pas oublier la distance maximale par rapport à un point d'origine
	// pour chaque personnage ainsi que la direction du personnage
	
	protected void moveUp(int positionY, int positionOrigineY)
	{
		if((positionY - positionOrigineY) < 3)
		{
			// Si pas d'obstacle sur la position (Y + 1)
		
			// Rotation vers le haut (animation)
			
			// Mouvement de un vers le haut (animation + déplacement)
		}
	}
	
	protected void moveDown(int positionY, int positionOrigineY)
	{
		if((positionOrigineY - positionY) < 3)
		{
			// Si pas d'obstacle sur la position (Y - 1)
			
			// Rotation vers le bas (animation)
			
			// Mouvement de un vers le bas (animation + déplacement)
		}
	}
	
	protected void moveLeft(int positionX, int positionOrigineX)
	{
		if((positionOrigineX - positionX) < 3)
		{
			// Si pas d'obstacle sur la position (X - 1)
			
			// Rotation vers la gauche (animation)
			
			// Mouvement de un vers la gauche (animation + déplacement)
		}
	}
	
	protected void moveRight(int positionX, int positionY)
	{
		if((positionX - positionOrigineX) < 3)
		{
			// Si pas d'obstacle sur la position (X + 1)
			
			// Rotation vers la droite (animation)
			
			// Mouvement de un vers la droite (animation / Déplacement
		}
	}
}

class Joueur : Personnage Mobile
{
	// Définition des particularités du joueur par rapport aux autres personnages (PNJ) ainsi que d'autres définitions principales
	// Surcharge des définitions de "PersonnagesMobiles" et de "Personnage" ?
}
