
namespace KalamazooTheater.Models;
public class AdminProductionModel
{
	public int ProductionId { get; set; }
	public int OrganizationId { get; set; }
	public string Title { get; set; }
	public string Subtitle { get; set; }
	public string Description { get; set; }
	public string Note { get; set; }
}
