using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using ExcelImport.Models;
using LinqToExcel;

namespace ExcelImport.Facade
{
    public class DataImporter
    {
        public void ImportHotelDetails()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_details.xls");
                var excelWorkSheets = excel.GetWorksheetNames();

                foreach (var excelWorkSheet in excelWorkSheets)
                {
                    var hotelsDetails = (from hotel in excel.Worksheet<HotelDetail>(excelWorkSheet)
                                       select hotel).ToList();

                    int count = hotelsDetails.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var detailsList = hotelsDetails.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + detailsList.First().sr);
                            Console.WriteLine("\t\t" + detailsList.Last().sr);

                            db.HotelDetails.AddRange(detailsList);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} hotel details", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }

                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void ImportRateDetails()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_rates.xls");
                var excelWorkSheets = excel.GetWorksheetNames();

                foreach (var excelWorkSheet in excelWorkSheets)
                {
                    var hotelsRates = (from hotel in excel.Worksheet<Rate>(excelWorkSheet)
                                       select hotel).ToList();

                    int count = hotelsRates.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var rateList = hotelsRates.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + rateList.First().sr);
                            Console.WriteLine("\t\t" + rateList.Last().sr);

                            db.Rates.AddRange(rateList);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} rate details", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }

                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void ImportHotelLocationDetails()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_location_info.xls");
                var sheets = excel.GetWorksheetNames();
                foreach (var sheet in sheets)
                {
                    var hotelLocations =
                        (from hotelLocation in excel.Worksheet<HotelLocationInfo>(sheet) select hotelLocation).ToList();

                    int count = hotelLocations.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var hotelLocationList = hotelLocations.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + hotelLocationList.First().sr);
                            Console.WriteLine("\t\t" + hotelLocationList.Last().sr);

                            db.HotelLocationInfoes.AddRange(hotelLocationList);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} hotel location details", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }
                
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void ImportHotelImages()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_image.xls");
                var excelWorkSheets = excel.GetWorksheetNames();

                foreach (var excelWorkSheet in excelWorkSheets)
                {
                    var hotelsImages = (from hotelImage in excel.Worksheet<HotelImage>(excelWorkSheet)
                                        select hotelImage).ToList();

                    int count = hotelsImages.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var hotelImageList = hotelsImages.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + hotelImageList.First().sr);
                            Console.WriteLine("\t\t" + hotelImageList.Last().sr);

                            db.HotelImages.AddRange(hotelImageList);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} hotel images", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }

                

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }

        }

        public void ImportHotelRatings()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_ratings.xls");
                var excelWorkSheets = excel.GetWorksheetNames();

                foreach (var excelWorkSheet in excelWorkSheets)
                {
                    var hotelsRatings = (from hotelsRating in excel.Worksheet<HotelRating>(excelWorkSheet)
                                         select hotelsRating).ToList();

                    int count = hotelsRatings.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var hotelsRatingList = hotelsRatings.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + hotelsRatingList.First().sr);
                            Console.WriteLine("\t\t" + hotelsRatingList.Last().sr);

                            db.HotelRatings.AddRange(hotelsRatingList);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} hotel ratings", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }

                

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        public void ImportHotelNearBy()
        {
            try
            {
                var excel = GetExcelSheet("n_hotel_nearby.xls");
                var excelWorkSheets = excel.GetWorksheetNames();

                foreach (var excelWorkSheet in excelWorkSheets)
                {
                    var hotelNearByList = (from hotelsNearBy in excel.Worksheet<HotelNearBy>(excelWorkSheet)
                                           select hotelsNearBy).ToList();

                    List<HotelNearBy> listToBeRemoved =
                        hotelNearByList.Where(nearBy => nearBy.sr == 20565 || nearBy.sr == 20566).Select(nearBy => nearBy).ToList();

                    hotelNearByList = hotelNearByList.Except(listToBeRemoved).ToList();

                    int count = hotelNearByList.Count;
                    int skipCount = 0;
                    int rounds = count / 100;

                    using (var db = new AkbarTravelsDbContext())
                    {
                        for (int i = 0; i <= rounds; i++)
                        {
                            var lstHotelNearBy = hotelNearByList.Skip(skipCount).Take(100).ToList();

                            Console.WriteLine();
                            Console.WriteLine("\t\t" + lstHotelNearBy.First().sr);
                            Console.WriteLine("\t\t" + lstHotelNearBy.Last().sr);

                            db.HotelNearBies.AddRange(lstHotelNearBy);
                            db.SaveChanges();

                            Console.WriteLine();

                            skipCount += 100;
                            Console.WriteLine("{0} completed of {1} hotel near by", i, rounds);
                            Console.WriteLine();
                        }
                    }

                }
                

            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
                throw;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw;
            }
        }

        private ExcelQueryFactory GetExcelSheet(string path)
        {
            return new ExcelQueryFactory(path);
        }
    }
}