#pragma once

namespace DnD {

class IArmour
{
public:
    virtual ~IArmour() = default;

    virtual int modifyAttack(int damage) const = 0;
};

} // namespace DnD