#pragma once

#include "IArmour.h"
#include "Item.h"

namespace DnD {

class Armour :
    public IArmour,
    private Item
{
public:
    Armour(const std::string& name, int weight);

private:
    std::string m_name;
    int m_weight;
};

} // namespace DnD