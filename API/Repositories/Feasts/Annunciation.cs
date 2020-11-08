﻿using Katameros.DTOs;
using Katameros.Enums;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Katameros.Repositories
{
    public partial class FeastsRepository
    {
        private async Task<DayReadings> ConstructAnnunciation()
        {
            DayReadings dayReadings = new DayReadings
            {
                Title = await GetFeastTranslation(Feast.Annunciation),
                Sections = new List<Section>
                {
                    await _readingsRepository.MakeVespers("19.144:5,7", "42.7:36-50"),
                    await _readingsRepository.MakeMatins("19.72:6-7", "42.11:20-28", null),
                    await _readingsRepository.MakeLitugy("45.3:1-31", "62.1:1-10*@+62.2:1-6", "44.7:23-34", "19.45:10-11", "42.1:26-38")
                }
            };
            return dayReadings;
        }
    }
}
