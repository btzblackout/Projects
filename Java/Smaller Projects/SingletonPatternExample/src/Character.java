
public class Character 
{
	private String name;
	private String bodyType;
	private String hairColor;
	private String eyeColor;
	private String sex;
	private int age;
	
	private static Character character;
	private Character()
	{
		
	}
	public static Character createCharacter(String name, String bodyType, String hairColor, String eyeColor, String sex, int age)
	{
		if(character == null)
		{
			character = new Character();
			character.setName(name);
			character.setBodyType(bodyType);
			character.setHairColor(hairColor);
			character.setEyeColor(eyeColor);
			character.setSex(sex);
			character.setAge(age);
		}
		return character;
	}
	public static Character createCharacter()
	{
		if(character == null)
		{
			character = new Character();
		}
		return character;
	}

	public String getName() {
		return name;
	}


	public void setName(String name) {
		this.name = name;
	}


	public String getBodyType() {
		return bodyType;
	}


	public void setBodyType(String bodyType) {
		this.bodyType = bodyType;
	}


	public String getHairColor() {
		return hairColor;
	}


	public void setHairColor(String hairColor) {
		this.hairColor = hairColor;
	}


	public String getEyeColor() {
		return eyeColor;
	}


	public void setEyeColor(String eyeColor) {
		this.eyeColor = eyeColor;
	}


	public String getSex() {
		return sex;
	}


	public void setSex(String sex) {
		this.sex = sex;
	}


	public int getAge() {
		return age;
	}


	public void setAge(int age) {
		this.age = age;
	}
	
}
