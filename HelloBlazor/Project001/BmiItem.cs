namespace Project001;

public class BmiItem
{
	public string Name { get; set; }
	public double Height { get; set; }
	public double Weight { get; set; }

	public double Bmi 
		=> Height == 0 ? 0.0f : Weight / ((Height / 100) * (Height / 100));
}