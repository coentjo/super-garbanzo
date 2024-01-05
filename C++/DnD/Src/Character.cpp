#include "Character.h"

namespace DnD {

void Character::setHealth(int health)
{
    m_health = health;
}

void Character::addHealth(int health)
{
    m_health += health;
}

}