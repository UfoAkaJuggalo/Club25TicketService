using System.Reflection;
using Club25_Domain.Aggregates.BandAggregate;
using Club25_Domain.Aggregates.BandAggregate.Entities;
using Club25_Domain.Aggregates.BookingAgencyAggregate;
using Club25_Domain.Aggregates.BookingAgencyAggregate.Entities;
using Club25_Domain.Aggregates.EventAggregate;
using Club25_Domain.Aggregates.EventAggregate.Entities;
using Club25_Domain.Aggregates.PromoterAgencyAggregate;
using Club25_Domain.Aggregates.PromoterAgencyAggregate.Entities;
using Club25_Domain.Aggregates.SponsorAggregate;
using Club25_Domain.Aggregates.SponsorAggregate.Entities;
using Club25_Domain.Aggregates.TicketAgencyAggregate;
using Club25_Domain.Aggregates.TicketAgencyAggregate.Entities;
using Club25_Domain.Aggregates.TicketPoolAggregate;
using Club25_Domain.Aggregates.TicketPoolAggregate.Entities;
using Club25_Domain.Aggregates.VenueAggregate;
using Club25_Domain.Aggregates.VenueAggregate.Entities;
using Club25_Domain.Common.Entities;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure_EF_SQLdB.Contexts;

public sealed class Club25Context : DbContext
{
	public Club25Context()
	{
	}

	public Club25Context(DbContextOptions<Club25Context> options)
		: base(options)
	{
	}

	public DbSet<BookingAgency> BookingAgencies { get; set; }
	public DbSet<Booker> Bookers { get; set; }
	public DbSet<BookingAgencyBand> BookingAgencyBands { get; set; }
	public DbSet<Artist> Artists { get; set; }
	public DbSet<Band> Bands { get; set; }
	public DbSet<Description> Descriptions { get; set; }
	public DbSet<Discount> Discounts { get; set; }
	public DbSet<Event> Events { get; set; }
	public DbSet<EventStageLineup> Lineups { get; set; }
	public DbSet<LineupEntry> LineupEntries { get; set; }
	public DbSet<Promoter> Promoters { get; set; }
	public DbSet<PromoterAgency> PromoterAgencies { get; set; }
	public DbSet<Sponsor> Sponsors { get; set; }
	public DbSet<SponsorRepresentative> SponsorRepresentatives { get; set; }
	public DbSet<SponsorContract> SponsorContracts { get; set; }
	public DbSet<Stage> Stages { get; set; }
	public DbSet<StageManager> StageManagers { get; set; }
	public DbSet<Sector> Sectors { get; set; }
	public DbSet<Seat> Seats { get; set; }
	public DbSet<Tag> Tags { get; set; }
	public DbSet<Ticket> Tickets { get; set; }
	public DbSet<TicketAgency> TicketAgencies { get; set; }
	public DbSet<TicketAgent> TicketAgents { get; set; }
	public DbSet<TicketPool> TicketPools { get; set; }
	public DbSet<Venue> Venues { get; set; }
	public DbSet<SponsorVenueContract> SponsorVenueContracts { get; set; }

	protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https: //go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
		=> optionsBuilder.UseSqlServer(
			"Data Source=HOFFMAN;Initial Catalog=Club25;Integrated Security=True;Connect Timeout=30;Encrypt=True;Trust Server Certificate=True;Application Intent=ReadWrite;Multi Subnet Failover=False");

	protected override void OnModelCreating(ModelBuilder modelBuilder)
	{
		modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly(),
		                                             type => type.Namespace.Contains("Club25Context"));

		modelBuilder.Entity<ArtistDescription>()
		            .ToTable(nameof(ArtistDescription));
		modelBuilder.Entity<BandDescription>()
		            .ToTable(nameof(BandDescription));
		modelBuilder.Entity<LinkDescription>()
		            .ToTable(nameof(LinkDescription));
		modelBuilder.Entity<SponsorDescription>()
		            .ToTable(nameof(SponsorDescription));
		modelBuilder.Entity<SponsorContractDescription>()
		            .ToTable(nameof(SponsorContractDescription));
		modelBuilder.Entity<EventStageDescription>()
		            .ToTable(nameof(EventStageDescription));
		modelBuilder.Entity<DiscountDescription>()
		            .ToTable(nameof(DiscountDescription));
		modelBuilder.Entity<TicketDescription>()
		            .ToTable(nameof(TicketDescription));
	}
}