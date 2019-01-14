using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace ckl.Extentions
{
    public static class IQueryableExtensions
    {
        public async static Task<string> ItemsToJson<T>(this IQueryable<T> items, string filter, string sort, string order, int limit, int offset)
        {
            try
            {
                if (!string.IsNullOrEmpty(filter))
                {
                    var filters = JsonConvert.DeserializeObject<Dictionary<string, string>>(filter);
                    List<string> whereConditions = new List<string>();

                    List<PropertyInfo> properties = typeof(T).GetProperties(BindingFlags.Public | BindingFlags.Instance).ToList();

                    foreach (var item in filters)
                        if (item.Value != null)
                            whereConditions.Add(FormatDynamicCondition(properties, item));

                    //if (whereConditions.Any())
                    //    items = items.Where(string.Join(" and ", whereConditions));
                }

                // where clause is set, count total records
                int count = await items.CountAsync();

                // Skip requires sorting, so make sure there is always sorting
                String sortExpression = "";

                if (sort != null && sort.Length > 0)
                {
                    //sortExpression += String.Format("{0} {1}", sort, order);
                    //items = items.OrderBy(sortExpression);
                }

                // show all records if limit is not set
                if (limit == 0)
                    limit = count;

                // Prepare json structure
                var result = new
                {
                    total = count,
                    rows = items.Skip(offset).Take(limit)
                };

                return JsonConvert.SerializeObject(result, Formatting.None, new JsonSerializerSettings()
                {
                    MetadataPropertyHandling = MetadataPropertyHandling.Ignore,
                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        private static string FormatDynamicCondition(List<PropertyInfo> properties, KeyValuePair<string, string> input)
        {
            string output = null;
            foreach (var prop in properties)
            {
                if (input.Key.ToLower().Equals(prop.Name.ToLower()))
                {
                    switch (Type.GetTypeCode(prop.PropertyType))
                    {
                        case TypeCode.Object:
                            if (prop.PropertyType == typeof(DateTime) || prop.PropertyType == typeof(DateTime?))
                                if (input.Key.ToUpper().Contains("START"))
                                    output = string.Format("{0} >= \"{1}\"", input.Key, input.Value);
                                else if (input.Key.ToUpper().Contains("END"))
                                    output = string.Format("{0} <= \"{1}\"", input.Key, input.Value);
                                else
                                    if (prop.PropertyType == typeof(DateTime))
                                    output = string.Format("{0}.Date == \"{1}\"", input.Key, input.Value);
                                else
                                    output = string.Format("{0}.Value.Date == \"{1}\"", input.Key, input.Value);
                            else if (prop.PropertyType == typeof(int?))
                                output = string.Format("{0} == {1}", input.Key, input.Value);
                            else
                                output = string.Format("{0}.Equals(Guid.Parse(\"{1}\"))", (Guid.TryParse(input.Value, out _) == true ?
                                    (input.Key.EndsWith("Id", StringComparison.OrdinalIgnoreCase) ? input.Key : string.Format("{0}Id", input.Key)) : // append "id" if not present
                                    input.Key), input.Value);
                            break;
                        case TypeCode.Int16:
                        case TypeCode.Int32:
                        case TypeCode.Int64:
                            output = string.Format("{0} == {1}", input.Key, input.Value);
                            break;
                        default:
                            output = string.Format("{0}.ToUpper().Contains(\"{1}\")", input.Key, input.Value.ToUpper());
                            break;
                    }
                }
            }
            return output;
        }
    }
}
